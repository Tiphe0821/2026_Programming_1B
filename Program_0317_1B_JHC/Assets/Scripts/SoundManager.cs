using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip audioClip; // 사운드 파일
    public AudioClip audioBGMClip; // 사운드 파일
    private AudioSource audioSource; // 사운드 재생

    private AudioSource audioSourceBGM; // 배경음 재생

    void Awake()
    {
        Instance = this;
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSourceBGM = gameObject.AddComponent<AudioSource>();

        SetVolume(1.0f);
        SetBGMVolume(0.5f);
    }
    private void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    private void SetBGMVolume(float volume)
    {
        audioSourceBGM.volume = volume;
    }
    public void PlaySound()
    {
        audioSource.PlayOneShot(audioClip);
    }

    public void PlayeBGMSound()
    {
        audioSourceBGM.clip = audioBGMClip;
        audioSourceBGM.loop = true;
        audioSourceBGM.Play();
    }

    public void OnOffBGM(bool isOn)
    {
        if(isOn)
        {
            audioSourceBGM.volume = 0.5f ;
        }
        else
        {
            audioSourceBGM.volume = 0f ;
        }
    }
    public void OnOffFx(bool isOn)
    {
        if(isOn)
        {
            audioSource.volume = 1f ;
        }
        else
        {
            audioSource.volume = 0f ;
        }
    }

    public void ChangeBGMVolume(float volume)
    {
        audioSourceBGM.volume = volume;
    }

    public void ChangeClickVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
