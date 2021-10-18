using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public AudioClip[] musicClips;
	public AudioClip[] sfxClips;

	List<AudioSource> musicAudioSources;
	List<AudioSource> sfxAudioSources;

	private void Start() {

		musicAudioSources = new List<AudioSource>();
		sfxAudioSources = new List<AudioSource>();

		foreach(var musicClip in musicClips) {
			var audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = musicClip;
			// Aquí se pueden checar los settings del jugador.
			audioSource.volume = 1;
			audioSource.loop = true;
			musicAudioSources.Add(audioSource);
		}

		foreach (var sfxClip in sfxClips) {
			var audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = sfxClip;
			// Aquí se pueden checar los settings del jugador.
			audioSource.volume = 1;
			audioSource.loop = false;
			sfxAudioSources.Add(audioSource);
		}

	}

	public AudioSource GetMusicAudioSourceBy(string name) {
		foreach(var musicSource in musicAudioSources) {
			if(musicSource.clip.name == name) {
				return musicSource;
			}
		}
		return null;
	}

	public void PlayMusicBy(string name) {
		foreach(var musicSource in musicAudioSources) {
			if(musicSource.clip.name == name) {
				musicSource.Play();
				return;
			}
		}
	}

	// Agregar las demás funciones
	// GetSFXAudioSourceBy
	// PlaySFXBy
	// SetVolumen

}