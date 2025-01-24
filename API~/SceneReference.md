# [SceneReference](../Runtime/SceneReference.cs)

Class in `Incantium` | Assembled in [`Incantium.SceneReference`](../README.md)

Implements 
[`ISerializationCallbackReceiver`](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/ISerializationCallbackReceiver.html)

## Description

The SceneReference is a wrapper class that is able to safely serialize a scene within a property field, so no 
string-based or build index lookup is required to load/unload a scene within Unity.

## Example

```csharp
using Incantium;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    [SerializeField]
    private SceneReference scene;

    private void Start()
    {
        scene.LoadAsync(LoadSceneMode.Additive);
    }
}
```

## Variables

### :green_book: `string` name

The name of the scene.

### :green_book: `int` index

The build index of the scene.

### :green_book: `bool` isLoaded

True after loading has completed and all objects have been enabled.

## Methods

### :green_book: `void` Load([`LoadSceneMode`](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.LoadSceneMode.html) mode = LoadSceneMode.Single)

Loads the scene.

### :green_book: [`AsyncOperation`](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AsyncOperation.html) LoadAsync([`LoadSceneMode`](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.LoadSceneMode.html) mode = LoadSceneMode.Single)

Loads the scene asynchronously in the background.

### :green_book: [`AsyncOperation`](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AsyncOperation.html) UnloadAsync()

Unloads the scene asynchronously in the background.
