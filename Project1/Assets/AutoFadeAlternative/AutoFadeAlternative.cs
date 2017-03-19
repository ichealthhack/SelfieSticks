using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoFadeAlternative : MonoBehaviour {

	private GameObject MainBlackWhitePanel;

	private float Timer;

	[Header("Speed of Fade and To Level variables")]
	public float SpeedOfFade;
	public int ToLevel;

	[Header("Fade to End")]
	public bool ToEnd;
	[Header("Fade from Start")]
	public bool FromStart;

	void Start () 
	{
		if(GameObject.FindWithTag("AutoFadeAlternative") != null)
		{
		    MainBlackWhitePanel = GameObject.FindWithTag ("AutoFadeAlternative");
		}
		else
		{
			Debug.LogError("Script *-AutoFadeAlternative-* is missing fade object! Variable name: MainBlackWhitePanel");
			Debug.LogWarning("Script *-AutoFadeAlternative-* requirement: if *AutoFadeAlternative* tag doesnt exist, so create it! Important requirement!");
		}

		if(FromStart)
		{
		    Timer = 1;
		}
		else
		{
			Timer = 0;
		}

		if(SpeedOfFade == 0)
		{
			SpeedOfFade = 0.5F;
		}
	}



	void Update () 
	{

		 //---------------------FADE IF FROMSTART IS ENABLED

		if(FromStart)
		{
			if(Timer>=0)
			{
			    Timer-=Time.deltaTime * SpeedOfFade;
			}
			else
			{
				FromStart = false;
				MainBlackWhitePanel.GetComponent<Image>().enabled = false;
			}
			MainBlackWhitePanel.GetComponent<Image>().color = new Color(0,0,0,Timer);
		}

		//---------------------FADE IF TOEND IS ENABLED

	    if(ToEnd)
		{
			if(Timer<=1)
			{
			    Timer+=Time.deltaTime * SpeedOfFade;
			}
			else
			{
				Application.LoadLevel(ToLevel);
			}
			MainBlackWhitePanel.GetComponent<Image>().color = new Color(0,0,0,Timer);
		}
	}

	public void Generate(float SpeedOfFadeVoid, int LevelVoid)
	{
		SpeedOfFade = SpeedOfFadeVoid;
		ToLevel = LevelVoid;

		MainBlackWhitePanel.GetComponent<Image>().enabled = true;

		ToEnd = true;
	}
	public void Generate_Alternative(int LevelVoid)
	{
		SpeedOfFade = 0.5F;
		ToLevel = LevelVoid;
		
		MainBlackWhitePanel.GetComponent<Image>().enabled = true;
		
		ToEnd = true;
	}
}
