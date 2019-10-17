using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class DisplayQuestion : MonoBehaviour
{
	int fontSize = 72;
	float cutoff = 10000;
	float timer;
	AudioSource aud;

	Stimulus myStimuli;

	// Use this for initialization
	void Start ()
	{
		if (!GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>())
		{
			Debug.LogError("Critical Failure! Initiating Self Destruct!");
		}

		myStimuli = GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ();

		do
		{
			myStimuli.questID = Random.Range(0, myStimuli.question.Length);
		}
		while(myStimuli.question [myStimuli.questID].AnsweredEh == true);

		aud = GetComponent<AudioSource>();

		aud.clip = Microphone.Start(null, true, 10, 44100);

		timer = cutoff;
	}

	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime * 1000;

		if (timer <= 0)
		{
			myStimuli.question [myStimuli.questID].Response = aud.clip;
			SavWav.Save(Stimulus.pID + "_" + (myStimuli.questID + 1), myStimuli.question[myStimuli.questID].Response);
			myStimuli.question [myStimuli.questID].AnsweredEh = true;

			myStimuli.completedEh = true;

			for (int cnt = 0; cnt < myStimuli.question.Length; cnt++)
			{
				if(!myStimuli.question[cnt].AnsweredEh)
				{
					myStimuli.completedEh = false;
					break;
				}
			}

			if (myStimuli.completedEh)
			{
				SceneManager.LoadScene ("Thanks");
			}
			else
			{
				SceneManager.LoadScene("OSPANCue");
			}
		}

		if (LevelMax () > 20)
		{
			myStimuli.question [myStimuli.questID].RT = cutoff - timer; 
		}
	}

	void OnGUI()
	{
		GUI.skin.box.fontSize = fontSize;
		GUI.Label(new Rect((Screen.width/2 - 2 * Stimulus.ppi), (Screen.height/2 - Stimulus.ppi), 4 * Stimulus.ppi, 2 * Stimulus.ppi ), myStimuli.question[myStimuli.questID].Noun, "Box");
	}

	float LevelMax()
	{
		float levelMax = 0;
		int _sampleWindow = 128;
		float[] waveData = new float[_sampleWindow];
		int micPosition = Microphone.GetPosition (null) - (_sampleWindow + 1);
		if (micPosition < 0) {
			return 0;
		}
		aud.clip.GetData (waveData, micPosition);
		for (int i = 0; i < _sampleWindow; ++i) {
			float wavePeak = waveData [i] * waveData [i];
			if (levelMax < wavePeak) {
				levelMax = wavePeak;
			}
		}
		return levelMax;
	}
}
