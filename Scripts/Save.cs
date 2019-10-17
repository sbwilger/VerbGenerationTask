using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Text;
using System.IO;

public class Save
{
	public void Savecsv()
	{
		if (!GameObject.FindGameObjectWithTag("Stimuli File").GetComponent<Stimulus>())
		{
			Debug.LogError("Critical Failure! Initiating Self Destruct!");
		}

		Stimulus myStimuli = GameObject.FindGameObjectWithTag ("Stimuli File").GetComponent<Stimulus> ();

		string fileName = "Saved_data.csv";
		string filePath = Path.Combine(Application.persistentDataPath, fileName);
		string delimiter = ",";  

		string[][] output = new string[][]
		{
			new string[]
			{
				"Participant ID",
				"Noun",
				"RT"
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[0].Noun,
				myStimuli.question[0].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[1].Noun,
				myStimuli.question[1].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[2].Noun,
				myStimuli.question[2].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[3].Noun,
				myStimuli.question[3].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[4].Noun,
				myStimuli.question[4].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[5].Noun,
				myStimuli.question[5].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[6].Noun,
				myStimuli.question[6].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[7].Noun,
				myStimuli.question[7].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[8].Noun,
				myStimuli.question[8].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[9].Noun,
				myStimuli.question[9].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[10].Noun,
				myStimuli.question[10].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[11].Noun,
				myStimuli.question[11].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[12].Noun,
				myStimuli.question[12].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[13].Noun,
				myStimuli.question[13].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[14].Noun,
				myStimuli.question[14].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[15].Noun,
				myStimuli.question[15].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[16].Noun,
				myStimuli.question[16].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[17].Noun,
				myStimuli.question[17].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[18].Noun,
				myStimuli.question[18].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[19].Noun,
				myStimuli.question[19].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[20].Noun,
				myStimuli.question[20].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[21].Noun,
				myStimuli.question[21].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[22].Noun,
				myStimuli.question[22].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[23].Noun,
				myStimuli.question[23].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[24].Noun,
				myStimuli.question[24].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[25].Noun,
				myStimuli.question[25].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[26].Noun,
				myStimuli.question[26].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[27].Noun,
				myStimuli.question[27].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[28].Noun,
				myStimuli.question[28].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[29].Noun,
				myStimuli.question[29].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[30].Noun,
				myStimuli.question[30].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[31].Noun,
				myStimuli.question[31].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[32].Noun,
				myStimuli.question[32].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[33].Noun,
				myStimuli.question[33].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[34].Noun,
				myStimuli.question[34].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[35].Noun,
				myStimuli.question[35].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[36].Noun,
				myStimuli.question[36].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[37].Noun,
				myStimuli.question[37].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[38].Noun,
				myStimuli.question[38].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[39].Noun,
				myStimuli.question[39].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[40].Noun,
				myStimuli.question[40].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[41].Noun,
				myStimuli.question[41].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[42].Noun,
				myStimuli.question[42].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[43].Noun,
				myStimuli.question[43].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[44].Noun,
				myStimuli.question[44].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[45].Noun,
				myStimuli.question[45].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[46].Noun,
				myStimuli.question[46].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[47].Noun,
				myStimuli.question[47].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[48].Noun,
				myStimuli.question[48].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[49].Noun,
				myStimuli.question[49].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[50].Noun,
				myStimuli.question[50].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[51].Noun,
				myStimuli.question[51].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[52].Noun,
				myStimuli.question[52].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[53].Noun,
				myStimuli.question[53].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[54].Noun,
				myStimuli.question[54].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[55].Noun,
				myStimuli.question[55].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[56].Noun,
				myStimuli.question[56].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[57].Noun,
				myStimuli.question[57].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[58].Noun,
				myStimuli.question[58].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[59].Noun,
				myStimuli.question[59].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[60].Noun,
				myStimuli.question[60].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[61].Noun,
				myStimuli.question[61].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[62].Noun,
				myStimuli.question[62].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[63].Noun,
				myStimuli.question[63].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[64].Noun,
				myStimuli.question[64].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[65].Noun,
				myStimuli.question[65].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[66].Noun,
				myStimuli.question[66].RT.ToString()
			},new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[67].Noun,
				myStimuli.question[67].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[68].Noun,
				myStimuli.question[68].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[69].Noun,
				myStimuli.question[69].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[70].Noun,
				myStimuli.question[70].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[71].Noun,
				myStimuli.question[71].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[72].Noun,
				myStimuli.question[72].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[73].Noun,
				myStimuli.question[73].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[74].Noun,
				myStimuli.question[74].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[75].Noun,
				myStimuli.question[75].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[76].Noun,
				myStimuli.question[76].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[77].Noun,
				myStimuli.question[77].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[78].Noun,
				myStimuli.question[78].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[79].Noun,
				myStimuli.question[79].RT.ToString()
			},
			new string[]
			{
				Stimulus.pID.ToString(),
				myStimuli.question[80].Noun,
				myStimuli.question[80].RT.ToString()
			}
		};

		int length = output.GetLength(0);  
		StringBuilder sb = new StringBuilder();  
		for (int index = 0; index < length; index++)
		{
			sb.AppendLine (string.Join (delimiter, output [index]));
		}

		if (!File.Exists (filePath))
		{
			File.WriteAllText (filePath, sb.ToString ());
		}
		else
		{
			File.AppendAllText(filePath, sb.ToString ());
		}
	}
}