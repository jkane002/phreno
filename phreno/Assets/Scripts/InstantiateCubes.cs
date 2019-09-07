using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    private const int numOfCubes = 200;
    private GameObject[] sampleCubeArr = new GameObject[numOfCubes];

    public GameObject cubePrefab;
    public float maxHeight;
    // Start is called before the first frame update
    void Start()
    {
        float cubeSeparation = -1 * (360.0f / (float)numOfCubes);

        for (int i = 0; i < numOfCubes; i++) {
            // creates an instance of a game object
            GameObject goCube = (GameObject)Instantiate(cubePrefab);
            goCube.transform.position = this.transform.position;
            goCube.transform.parent = this.transform;
            goCube.name = "Cube_" + i;

            // 360 / numOfCubes
            this.transform.eulerAngles = new Vector3(0, cubeSeparation * i, 0);
            goCube.transform.position = Vector3.forward * 100;
            sampleCubeArr[i] = goCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < numOfCubes; i++) {
            if (sampleCubeArr != null) {
                sampleCubeArr[i].transform.localScale = new Vector3(10,
                    AudioMain.audioSamples[i] * maxHeight + 2,10);
            }
        }
    }
}
