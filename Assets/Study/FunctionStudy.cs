using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sample());
    }

    // Update is called once per frame
    void Update()
    {

    }

    int Sample()
    {
        return 3;
    }




    //기본형태
    void Test(string name, int act = 1)
    {
        Debug.Log($"{name}이 행동{act}를 했다.");
    }
    void Test(string name, int act, int act1)
    {
        Debug.Log($"{name}이 행동{act}를 한뒤 {act1} 했다.");
    }


    void Eat(string name, string food)
    {
        Debug.Log($"{name}는 {food}를 먹었다");
    }

}
