using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeLightButton : MonoBehaviour
{
    // create camera list that can be updated in the inspector
    public List<Light> Lights;

    // create frame and button variables 
    private VisualElement frame;
    private Button button;

    // This function is called when the object becomes enabled and active.
    void OnEnable()
    {
        // get the UIDocument component (make sure this name matches!)
        var uiDocument = GetComponent<UIDocument>();
        // get the rootVisualElement (the frame component)
        var rootVisualElement = uiDocument.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        // get the button, which is nested in the frame
        button = frame.Q<Button>("Button");
        // create event listener that calls ChangeCamera() when pressed
        button.RegisterCallback<ClickEvent>(ev => ChangeLight());
    }

    // initialize click count
    int click = 0;
    private void ChangeLight(){
        EnableLight(click);
        click++;
        // reset counter so it is not out of bounds (only have 4 cameras)
        if(click >2){
            click = 0;
        }
    }

    private void EnableLight(int n)
    {
        Debug.Log("hello");
        // disable each of the cameras
        if (click == 0)
        {
            Lights.ForEach(light => light.enabled = false);
            Lights.ForEach(light => Debug.Log(light.name + light.enabled));
        }
        if (click == 2)
        {
            Debug.Log("cheese");
            Lights.ForEach(light => light.enabled = true);
            Lights.ForEach(light => light.intensity = light.intensity * 2);

        }

        if (click == 1)
        {
            Debug.Log("cheese");
            Lights.ForEach(light => light.enabled = true);
            Lights.ForEach(light => light.intensity = light.intensity/2);
        }
        // Cameras.ForEach(cam => cam.depth = 0);

        // enable the selected camera
        //Cameras[n].enabled = true;
        // Cameras[n].depth = 1;

    }

    
    
}
