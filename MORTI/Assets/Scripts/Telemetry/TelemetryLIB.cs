using System.Collections;
using UnityEngine.Networking;
using UnityEngine;

public class TelemetryLIB
{

    public static string globalURI = "http://ec2-3-137-219-57.us-east-2.compute.amazonaws.com:8080/api";
    // Start is called before the first frame update
    

    public static IEnumerator startSim()
    {

        using (UnityWebRequest webRequest = UnityWebRequest.Get(globalURI + "/simulationcontrol/sim/1/stop"))
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
        using (UnityWebRequest webRequest = UnityWebRequest.Get(globalURI + "/simulationcontrol/sim/1/start"))
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


    // Update is called once per frame
    public static IEnumerator getData()
    {
        //make the request to the server to start the simulation
        using (UnityWebRequest webRequest = UnityWebRequest.Get(globalURI + "/simulationstate/1"))
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

    public static IEnumerator pauseSim()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(globalURI + "/simulationcontrol/sim/1/pause"))
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

