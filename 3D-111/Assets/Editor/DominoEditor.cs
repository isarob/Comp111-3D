using UnityEngine;
using UnityEditor;

// Declare type of Custom Editor
[CustomEditor(typeof(Domino))]
public class TankControllerEditor : Editor 
{
 Domino _target;
 //get the reference when starting inspection
 void OnEnable(){
     //target returns Object, so we cast it
     _target = (Domino)target; 
 }
    // OnInspector GUI
    public override void OnInspectorGUI()
    {
 DrawDefaultInspector();
          if(GUILayout.Button("Spawn")) {
          _target.createDomino();
     }
    }
}