using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Toggle bgmToggle;
    public Toggle fxToggle;

    public Slider BGMSlider;
    public Slider FXSlider;

    private void Start()
    {
        bgmToggle.onValueChanged.AddListener(SoundManager.Instance.OnOffBGM);
        fxToggle.onValueChanged.AddListener(SoundManager.Instance.OnOffFx);

        BGMSlider.onValueChanged.AddListener(SoundManager.Instance.ChangeBGMVolume);
        FXSlider.onValueChanged.AddListener(SoundManager.Instance.ChangeClickVolume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
