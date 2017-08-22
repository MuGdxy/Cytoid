﻿using UnityEngine;
using UnityEngine.UI;

public class TpView : MonoBehaviour {

	private Text text;
	
	private GameController game;

	private void Awake()
	{
		text = GetComponent<Text>();
	}

	private void Start()
	{
		game = GameController.Instance;
	}

	private void FixedUpdate()
	{
		if (game.IsPaused) return;
		text.text = (game.PlayData == null || game.PlayData.NoteCleared == 0) ? "100% Accuracy" : game.PlayData.Tp.ToString("0.##") + "% Accuracy";
	}
	
}
