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




    //�⺻����
    void Test(string name, int act = 1)
    {
        Debug.Log($"{name}�� �ൿ{act}�� �ߴ�.");
    }
    void Test(string name, int act, int act1)
    {
        Debug.Log($"{name}�� �ൿ{act}�� �ѵ� {act1} �ߴ�.");
    }


    void Eat(string name, string food)
    {
        Debug.Log($"{name}�� {food}�� �Ծ���");
    }

}
