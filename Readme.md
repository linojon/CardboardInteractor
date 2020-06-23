# XR Cardboard Interactor #

_Helpers for integrating Google Cardboard XR Plugin with the Unity XR Interaction Toolkit_

These assets provide a simple way to use the XR Interaction Toolkit with the Cardboard XR Plugin. 

* Blog post: https://medium.com/@linojon/an-xr-cardboard-interactor-for-unity-eec6270be2e9
* Repository: https://github.com/linojon/CardboardInteractor


Cardboard plugin documentation:

* Google Cardboard XR Plugin for Unity: https://github.com/googlevr/cardboard-xr-plugin
* Quickstart for Google Cardboard for Unity: https://developers.google.com/cardboard/develop/unity/quickstart

## Quick Start ##

1. Install XR Plugin Management (Edit > Project Settings > XR Plugin Management)
2. Add the Cardboard plugin package via url (Window > Package Manager > + > Add Package From Git URL) and paste the Google url (`https://github.com/googlevr/cardboard-xr-plugin.git`)
3. Add an XR Rig to your scene (GameObject > XR > Stationary XR Rig)
4. Delete or disable the LeftHand Controller and RightHand Controller

**Make the Main Camera an interactor**

On the Main Camera game object, 
1. Add an XR Ray Interactor component
2. Add the XRCardboardController script from this package
3. It's recommended you create an Interactable layer and set the Interactables Layer mask on the component
3. Add the Reticle prefab as a child of Main Camera, set Position Z=2

The camera will now interact with UI buttons on a world canvas

**Make an object a Cardboard interactable**

To make a game object interactable, on the object,
1. Add a CardboardInteractable script from this package

The camera will now interact with the game object. The default mechanic is you point-and-click to select, move your head, then point-and-click again to unselect.

Note the On Hover Enter, On Hover Exit, On Select Enter, and On Select Exit actions are comparable to the XRI interactable ones.

**Demo scene**

The CardboardInteractableDemo scene gives a simple example.




