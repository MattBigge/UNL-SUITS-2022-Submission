using System.Collections;
using UnityEngine.Networking;
using UnityEngine;

public static class TelemetryFunctions
{
    // Start is called before the first frame update
    void startTelemetryStream()
    {
        //Call function and wait for a response
        StartCoroutine(StartSim("http://ec2-3-137-219-57.us-east-2.compute.amazonaws.com:8080/api/simulationcontrol/sim/1/start"));
    }

    private void startSim(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();
            switch(webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                    Debug.Log("Connection Error");
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.Log("Data Processing Error");
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.Log("Protocol Error");
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log("Success" + " " + webRequest.downloadHandler.text);
                    break;
            }
        }
    }

    void Update(){
        StartCoroutine(GetRequest("localhost:8080/api/simulationstate/1"));
    }

    // Update is called once per frame
    IEnumerator GetRequest(string uri)
    {
        //make the request to the server to start the simulation
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();
            switch(webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                    Debug.Log("Connection Error");
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.Log("Data Processing Error");
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.Log("Protocol Error");
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log("Success" + " " + webRequest.downloadHandler.text);
                    break;
            }
        }
    }
}
