using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSurface : MonoBehaviour
{
    [Header("Surface Sounds")]
    [Tooltip("Sound played when player walking on surface")]
    public AudioClip SurfaceFootstepClip = null;

    [Tooltip("Sound played when object collides with clip")]
    public AudioClip SurfaceCollisionClip = null;

}
