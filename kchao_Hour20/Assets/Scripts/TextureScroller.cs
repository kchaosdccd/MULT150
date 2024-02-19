using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    new Renderer renderer;
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // increase offset based on time
        offset += Time.deltaTime * speed;
        // keep offset between 0 and 1
        if (offset > 1)
            offset -= 1;
        // apply the offset to the material
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}
