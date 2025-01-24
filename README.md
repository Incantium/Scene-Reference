# Scene Reference

![Unity version](https://img.shields.io/badge/2022.3+-cccccc?logo=unity)
![.NET version](https://img.shields.io/badge/Standard_2.1-5027d5?logo=dotnet)
![C# version](https://custom-icon-badges.demolab.com/badge/9.0-67217a?logo=cshrp)

## Overview

Normally, you cannot reference to a scene through the Unity Editor. Instead, you have to use string-based lookup or the
build index to load in new scenes, both of which are highly unreliable and prone to errors. Just changing the name of 
the scene or its index, and the whole game breaks.

This package makes it possible to create a referencable field within the Unity Editor to reference scenes. Because this
package is build-safe, it can be safely used in your Unity games. And with a reference to the scene, you don't have to
worry about changing names or its build index.

## Installation instructions

- Open the [Package Manager](https://docs.unity3d.com/Manual/upm-ui.html) in a Unity project.
- Click on the "+" button to add a new package.
- Click on "Install package from git URL...".
- Put in `https://github.com/Incantium/Scene-Reference.git`.
- Click on "Install" or press enter.
- Enjoy!

## Workflow

Originally, you may have code like this:

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleClass : MonoBehaviour
{
    [SerializeField]
    private string scene;

    private void Start()
    {
        SceneManager.LoadScene(scene);
    }
}
```

But with a SceneReference, you can enhance it to this:

```csharp
using Incantium;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    [SerializeField]
    private SceneReference scene;

    private void Start()
    {
        scene.Load();
    }
}
```

## References

| Class                                    | Description                                                                                   |
|------------------------------------------|-----------------------------------------------------------------------------------------------|
| [SceneReference](API~/SceneReference.md) | Class responsible for creating a referencable field in the Unity inspector for a Unity scene. |

## Frequently Asked Questions

### Which Unity versions are compatible with this package?

This package is heavily tested in `Unity 2022.3.44f1` and `Unity 6000.0.25f1`. It is expected that this package also
works in older and newer versions of the Unity Editor because it is not dependent on any other Unity package.

### How likely is a scene reference to break?

Every package made for Unity has the same problems as Unity itself, namely that some things can break. In this case, the
cached name of the scene it is referenced to can get out of sync. 

This package is made in such way that changing the name of the scene, even while not loading this reference, will not
get the cached property out of sync. Throughout all the usage in different Unity projects, not once did it break.

### Can this package be used with others?

This package is automatically integrated with the [Required](https://github.com/Incantium/Required) package, also from 
Incantium.
