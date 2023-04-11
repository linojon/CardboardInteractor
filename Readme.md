# XR Cardboard Interactor #

_Helpers for integrating Google Cardboard XR Plugin with the Unity XR Interaction Toolkit_

These assets provide a simple way to use the XR Interaction Toolkit with the Cardboard XR Plugin. 

* Blog post: https://medium.com/@linojon/an-xr-cardboard-interactor-for-unity-eec6270be2e9
* Repository: https://github.com/linojon/CardboardInteractor


Cardboard plugin documentation:

* Google Cardboard XR Plugin for Unity: https://github.com/googlevr/cardboard-xr-plugin
* Quickstart for Google Cardboard for Unity: https://developers.google.com/cardboard/develop/unity/quickstart

## Quick Start ##

The following instructions are updated to Unity 2021.3.21f1 LTS, but they should be valid for a wide range of versions.

1. Install XR Plugin Management (Edit > Project Settings > XR Plugin Management)
2. From Windows > Package Manager, install `XR Interaction Toolkit` and make sure that also the `XR Plugin Management` got installed
3. Still in Package Manager, add the Google Cardboard SDK package (`https://github.com/googlevr/cardboard-xr-plugin.git`) via url (+ > Add Package From Git URL);
4. Follow the instructions to set up the Google Cardboard SDK `https://developers.google.com/cardboard/develop/unity/quickstart`
5. Either open the CardboardInteractorDemo scene or set up your own.

## Use the Demo Scene ##

This repository can be directly opened from Unity Hub. In the _Assets\CardboardHelpers\Demo_ folder the `CardboardInteractableDemo` scene gives a simple example on how to use the CardboardInteractor.

## Set up your own Scene

The demo scene can be easily used for your own purposes by simply deleting those GameObjects not required by your projects. However it's also quite simple to set up your own Scene from scratch.

Start a new empty 3D project. The standard `Main Camera` component will be added, together with a default lighting.

### Make the Main Camera an Interactor

On the Main Camera game object:
1. right-click the `Main Camera` object and select `XR > Convert Main Camera To XR Rig`: now the `Main Camera` will be wrapped by an `XR Rig` GameObject; you may want to adjust its Transform properties to place it in an appropriate position;
2. on the newly created `XRRig`, through the `Add Component` button, add an `XR Origin` component and set its attributes:
   1. drag `Camera Offset` contained in `XRRig` to `Camera Floor Offset Object` property;
   2. drag `Main Camera` contained in `XRRig>Camera Offset` to `Camera Game Object` property;
3. select this latter `Main Camera` object and add the following Components:
   1. `XR Controller (Device-based)` and set the `Controller Node` property to `Left Eye`
   2. `XR Ray Interactor` and set the `Select Action Trigger` to `State Change`
   3. `XR Cardboard Controller` i.e. the script contained in this repository
4. it's recommended to create an Interactable layer and set the Interactables Layer Mask on `XR Cardboard Controller`
5. add the `Reticle` prefab as a child of Main Camera, set Position Z=2

The camera will now interact with UI buttons on a world canvas

### Set the XR Interaction Manager
On the current scene:
1. add a new XR > Interaction Manager
2. go back to the `XRRig > Camera Offset > Main Camera` object and in the `XR Ray Interactor` set the property `Interaction Manager` to the newly created `XR Interaction Manager`

### Make an object a Cardboard Interactable

To make a game object interactable, on the object:
1. add a `CardboardInteractable` script from this package

The camera will now interact with the game object. The default mechanic is you point-and-click to select, move your head, then point-and-click again to unselect.

Note the On Hover Enter, On Hover Exit, On Select Enter, and On Select Exit actions are comparable to the XRI interactable ones.

## Settings
The _XRCardboardController_ scripts holds a flag called `Make All Buttons Clickable` that automatically adds a `CardboardButtonClickable` Script Component to any GameObject of type `Button`. This script will automatically invoke the standard `OnClick()` event of the Button.

## Troubleshooting
- *The Sphere does not get highlighted when the reticle is pointing to the Cube*: by copying and pasting the Cube and Sphere GameObjects it is likely that some reference can be corrupted. Typical symptom is when you point to the cube and the sphere is not highlighted. Two main reasons:
   + the alpha channel of the `Hover` and `Select` colors rolled back to zero, thus rendering only a transparent color; set it back to one;
   + the Cardboard Interactable component of Cube might have wrong link to the Sphere Highlighter script. Please set them back manually after copying.
- *I don't see the reticle/crossair*: you probably didn't set the Z position of the reticle;

