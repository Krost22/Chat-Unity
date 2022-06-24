/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conexion : MonoBehaviour
{
    public bool useNat = false;
    public int Numero_Usuarios = 16;

    public void CrearServidor(){

        if(NetworkManager.peerType == NetworkPeerType.Disconnected){
            NetworkManager.InitializeServer(Numero_Usuarios , 5000, useNat);
            foreach (GameObject go in FindObjectsOfType(typeof(GameObject)) as GameObject[]) {
                go.SendMessage("OnNetworkLoaderLevel", SendMessageOptions.DontRequireReceiver); 
            }
        }
    }
}
*/
