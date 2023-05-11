using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConWallButtonischeck : MonoBehaviour
{
    public UiEunitConWallButton isCheck;
    public bool mCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mCheck = isCheck.IsPressed;
    }
}
