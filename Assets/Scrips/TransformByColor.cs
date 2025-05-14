using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransformByColor : ITransformable
{
    Material prepucio;
    List<MeshRenderer> meshes;
    public TransformByColor(Material prepucio, List<MeshRenderer> meshes)
    {
        this.prepucio = prepucio;
        this.meshes = meshes;
    }

    public void Transform()
    {
        for (int i = 0; i < meshes.Count; i++)
        {
            meshes[i].material = prepucio;
        }
    }

}
