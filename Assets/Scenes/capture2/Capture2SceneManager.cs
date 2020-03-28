using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capture2SceneManager : PocketDroidsSceneManager
{
    public override void playerTapped(GameObject player)
	{
		print("boople player");
	}

    public override void droidTapped(GameObject droid)
	{
		print("boople droind");
	}
}
