using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option PRG/Mouse Look
public class MouseLook : MonoBehaviour
{
    /*
     enums are what we call state value variables 
     they are comma separated lists of identifiers
     we can use them to create Types or Categorys
         */
    #region RotationalAxis
    //Create a public enum called RotationalAxis
    
    #endregion
    #region Variables
    //[Header("Rotation")]
    //create a public link to the rotational axis called axis and set a defualt axis
    //[Header("Sensitivity")]
    //public floats for our x and y sensitivity
    //[Range(0, 100)]
    //[Header("Y Rotation Clamp")]
    //max and min Y rotation
    //we will have to invert our mouse position later to calculate our mouse look correctly
    //float for rotation Y
    #endregion
    #region Start
        //Lock Cursor to middle of screen
        //Hide Cursor from view
        //if our game object has a rigidbody attached to it
            //set the rigidbodys freezRotaion to true
    #endregion
    #region Update
        #region Mouse X
        //else if we are rotating on the X
            //transform the rotation on our game objects Y by our Mouse input Mouse X times X sensitivity
            //x                y                          z
        #endregion
        #region Mouse Y
        //else we are only rotation on the Y
            //our rotation Y is pulse equals  our mouse input for Mouse Y times Y sensitivity
            //the rotation Y is clamped using Mathf and we are clamping the y rotation to the Y min and Y max
            //transform our local position to the nex vector3 rotaion - y rotaion on the x axis and local euler angle Y on the y axis
    #endregion
    #endregion
}













