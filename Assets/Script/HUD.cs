using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class HUD : MonoBehaviour
{

    VisualElement root;
    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
    }

    void Start()
    {
        TextField titleField = root.Q<TextField>("TitleField");
        IntegerField valueField = root.Q<IntegerField>("IntergerField");
        ProgressBar progressBar = root.Q<ProgressBar>("Default");

        titleField.RegisterCallback<ChangeEvent<string>>(x => progressBar.title = x.newValue);
        valueField.RegisterCallback<ChangeEvent<uint>>(x => progressBar.value = x.newValue);
    }
}
