﻿using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour
{
	static AudioController _instance;

	void Awake ()
	{
		if (_instance != null)
			Destroy(gameObject);
		else
		{
			DontDestroyOnLoad(gameObject);
			_instance = this;
			audio.Play();
		}
	}
}
