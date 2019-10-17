using UnityEngine;
using System.Collections;

public class Stimulus : MonoBehaviour
{
	public static int pID;
	public static int ppi;
	public bool completedEh;

	public VerbQuestion[] question;
	public int questID = -1;

	int rng;

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);

		Stimulus.ppi = (int)Screen.dpi;

		pID = 501;

		question = new VerbQuestion[81];

		question [0] = new VerbQuestion ("Anchor");			question [1] = new VerbQuestion ("Bed");			question [2] = new VerbQuestion ("Bottle");
		question [3] = new VerbQuestion ("Comb");			question [4] = new VerbQuestion ("Fan");			question [5] = new VerbQuestion ("Hammer");
		question [6] = new VerbQuestion ("Knife");			question [7] = new VerbQuestion ("Palette");		question [8] = new VerbQuestion ("Plant");
		question [9] = new VerbQuestion ("Shirt");			question [10] = new VerbQuestion ("Television");	question [11] = new VerbQuestion ("Turtle");
		question [12] = new VerbQuestion ("Apple");			question [13] = new VerbQuestion ("Bee");			question [14] = new VerbQuestion ("Bread");
		question [15] = new VerbQuestion ("Crab");			question [16] = new VerbQuestion ("Fish");			question [17] = new VerbQuestion ("Hand");
		question [18] = new VerbQuestion ("Light");			question [19] = new VerbQuestion ("Pear");			question [20] = new VerbQuestion ("Rabbit");
		question [21] = new VerbQuestion ("Shoe");			question [22] = new VerbQuestion ("Tiger");			question [23] = new VerbQuestion ("Wheel");
		question [24] = new VerbQuestion ("Baby");			question [25] = new VerbQuestion ("Bell");			question [26] = new VerbQuestion ("Broom");
		question [27] = new VerbQuestion ("Cub");			question [28] = new VerbQuestion ("Flashlight");	question [29] = new VerbQuestion ("Hanger");
		question [30] = new VerbQuestion ("Lion");			question [31] = new VerbQuestion ("Pen");			question [32] = new VerbQuestion ("Rake");
		question [33] = new VerbQuestion ("Snake");			question [34] = new VerbQuestion ("Tire");			question [35] = new VerbQuestion ("Whistle");
		question [36] = new VerbQuestion ("Ball");			question [37] = new VerbQuestion ("Bench");			question [38] = new VerbQuestion ("Carrot");
		question [39] = new VerbQuestion ("Dinosaur");		question [40] = new VerbQuestion ("Football");		question [41] = new VerbQuestion ("Helicopter");
		question [42] = new VerbQuestion ("Motorcycle");	question [43] = new VerbQuestion ("Pencil");		question [44] = new VerbQuestion ("Rope");
		question [45] = new VerbQuestion ("Sock");			question [46] = new VerbQuestion ("Toaster");		question [47] = new VerbQuestion ("Windmill");
		question [48] = new VerbQuestion ("Balloons");		question [49] = new VerbQuestion ("Bicycle");		question [50] = new VerbQuestion ("Cat");
		question [51] = new VerbQuestion ("Dog");			question [52] = new VerbQuestion ("Frog");			question [53] = new VerbQuestion ("Horse");
		question [54] = new VerbQuestion ("Mouse");			question [55] = new VerbQuestion ("Piano");			question [56] = new VerbQuestion ("Scissors");
		question [57] = new VerbQuestion ("Spoon");			question [58] = new VerbQuestion ("Tomato");		question [59] = new VerbQuestion ("Baseball");
		question [60] = new VerbQuestion ("Bird");			question [61] = new VerbQuestion ("Chair");			question [62] = new VerbQuestion ("Door");
		question [63] = new VerbQuestion ("Glove");			question [64] = new VerbQuestion ("Kangaroo");		question [65] = new VerbQuestion ("Net");
		question [66] = new VerbQuestion ("Pig");			question [67] = new VerbQuestion ("Shark");			question [68] = new VerbQuestion ("Suitcase");
		question [69] = new VerbQuestion ("Train");			question [70] = new VerbQuestion ("Bat");			question [71] = new VerbQuestion ("Boot");
		question [72] = new VerbQuestion ("Clown");			question [73] = new VerbQuestion ("Ear");			question [74] = new VerbQuestion ("Hair");
		question [75] = new VerbQuestion ("Key");			question [76] = new VerbQuestion ("Paintbrush");	question [77] = new VerbQuestion ("Pipe");
		question [78] = new VerbQuestion ("Ship");			question [79] = new VerbQuestion ("Cell Phone");	question [80] = new VerbQuestion ("Truck");
	}
}