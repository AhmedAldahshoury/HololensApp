//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
//
using UnityEngine;
using System.Collections;
using System;
using HUX.Interaction;
using HUX.Dialogs;



namespace HUX.Receivers
{
    /// <summary>
    /// Simple receiver class for toggling a game object active or inactive.
    /// </summary>
    public class ToggleActiveReceiver : InteractionReceiver
    {
        public GameObject CompleteCube;
        public GameObject CompleteSphere;
        public GameObject CompleteBed;
        public GameObject CompleteTV;
        public GameObject CompleteBike;
        public GameObject CompleteTreadmill;
        public GameObject CompletePlant;
        public GameObject CompleteTable;
        public GameObject visualObj;

        // When selected toggle color change
        protected override void OnTapped(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
        {
          //  if ((visualObj.))
            //{
              //  EditorUtility.DisplayDialog("TaaDaa", "Please adjust existing object before intializing a new one", "OK", "Cancel");

//            }
            switch (obj.name)
            {
                case "CubeHoloBtn":
                    // Do something on ButtonMeshPrimitive:OnTapped
                    Instantiate(CompleteCube, visualObj.transform.position, visualObj.transform.rotation);
                    break;

                case "SphereHoloBtn":
                    // Do something on ButtonMeshPrimitive:OnTapped
                    Instantiate(CompleteSphere, visualObj.transform.position, visualObj.transform.rotation);
                    break;

                case "BedHoloBtn":
                //    Transform objectNew = GameObject.Instantiate(sofa, obj.transform.position, Quaternion.identity).transform;
                    Instantiate(CompleteBed, visualObj.transform.position, visualObj.transform.rotation);
                    break;

                case "TVHoloBtn":
                    // Do something on ButtonPush:OnTapped
                    Instantiate(CompleteTV, visualObj.transform.position, visualObj.transform.rotation);
                    break;

                case "BikeHoloBtn":
                  //  Transform objectNew = GameObject.Instantiate(dresser, obj.transform.position, Quaternion.identity).transform;

                    Instantiate(CompleteBike, visualObj.transform.position, visualObj.transform.rotation);
                    break;

                case "TreadmillHoloBtn":
                    Instantiate(CompleteTreadmill, visualObj.transform.position, visualObj.transform.rotation);

                    // Do something on ButtonMeshBucky:OnTapped
                    break;

                case "PlantHoloBtn":
                    Instantiate(CompletePlant, visualObj.transform.position, visualObj.transform.rotation);

                    // Do something on ButtonHolographic:OnTapped
                    break;

                case "TableHoloBtn":
                    Instantiate(CompleteTable, visualObj.transform.position, visualObj.transform.rotation);

                    // Do something on ButtonTraditional:OnTapped
                    break;

                case "ButtonBalloon":
                    // Do something on ButtonBalloon:OnTapped
                    break;

                case "ButtonCheese":
                    // Do something on ButtonCheese:OnTapped
                    break;
                
            }
            base.OnTapped(obj, eventArgs);
        }

     
    }

}