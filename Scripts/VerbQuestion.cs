using UnityEngine;
using System.Collections;

public class VerbQuestion
{
	private string _noun;
	private float _rt;
	private AudioClip _response;
	private bool _answeredEh;

	public string Noun
	{
		get
		{
			return _noun;
		}
	}

	public AudioClip Response
	{
		get
		{
			return _response;
		}
		set
		{
			_response = value;
		}
	}

	public float RT
	{
		get
		{
			return _rt;
		}
		set
		{
			_rt = value;
		}
	}

	public bool AnsweredEh
	{
		get
		{
			return _answeredEh;
		}
		set
		{
			_answeredEh = value;
		}
	}

	public VerbQuestion(string noun)
	{
		_noun = noun;
	}
}
