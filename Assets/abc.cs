using System.Collections;
using UnityEngine;

public class abc : MonoBehaviour
{ private void Start()

    {

        StartCoroutine(Run());

    }

    private IEnumerator Run()

    {

        while (true)

        {

            // 5–7 calls

            int count = Random.Range(5, 8);

            for (int i = 0; i < count; i++)

            {

                MyFunction();

                // 0.5–1.5 seconds

                yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));

            }

            // 10–20 second break

            yield return new WaitForSeconds(Random.Range(10f, 20f));

        }

    }

    private void MyFunction()

    {
        WakaTime.Plugin.SendHeartbeat();
    }
}
