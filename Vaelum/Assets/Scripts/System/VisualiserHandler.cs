using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VisualiserHandler : MonoBehaviour
{

    public Volume volume;

    public RectTransform[] visualiserObjects;

    private float flashSensitivity = 0.9f;

    private float hitFlash = 0.2f;

    public SpriteRenderer background;

    public SpriteRenderer flashBackground;

    public AudioSource songSource;

    public GameObject fullComboEffect;

    bool loop = true;

    public int visualizerSimples = 64;

    public float minHeight = 15.0f;
    public float maxHeight = 425.0f;

    public float updateSensitivity = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        visualiserObjects = GetComponentsInChildren<RectTransform>();

        Invoke("GetSongSource", 1f);

    }

    

    void GetSongSource()
    {
        songSource = GameObject.FindGameObjectWithTag("NoteList").GetComponent<AudioSource>();
    }

    void fullCombo()
    {
        volume.weight = 2f;
        Instantiate(fullComboEffect);
        Invoke("resetVolume", 3f);
    }


    void resetVolume()
    {
        volume.weight = 0;
    }

    void hitNote()
    {
        flashBackground.color = new Color(1, 1, 1, 0.03f);
        Invoke("resetBackground", 0.1f);
    }

    void resetBackground()
    {
        flashBackground.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }


    // Update is called once per frame
    void Update()
    {
        float[] spectrumData = songSource.GetSpectrumData(visualizerSimples, 0, FFTWindow.Rectangular);

        for (int i = 1; i < visualiserObjects.Length; i++)
        {
            Vector2 newSize = visualiserObjects[i].GetComponent<RectTransform>().rect.size;

            newSize.y = Mathf.Clamp(Mathf.Lerp(newSize.y, minHeight + (spectrumData[i] * (maxHeight - minHeight) * 5.0f), updateSensitivity), minHeight, maxHeight);

            visualiserObjects[i].GetComponent<RectTransform>().sizeDelta = newSize;
        }

        float spec = (spectrumData[1] * 2);

        background.color = Color.Lerp(new Color(0.12f + spec, 0.12f + spec, 0.12f + spec), new Color(0.12f, 0.12f, 0.12f), flashSensitivity);

    }
}
