using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class Test : MonoBehaviour
{

    Thread m_Thread;
    UdpClient m_Client;


    void Start()
    {
        m_Thread = new Thread(new ThreadStart(ReceiveData));
        m_Thread.IsBackground = true;
        m_Thread.Start();
    }

    private void Update()
    {
        udpSend();
        ReceiveData();
    }

    void ReceiveData()
    {

        try
        {

            m_Client = new UdpClient(8887);
            m_Client.EnableBroadcast = true;
            //while (true)
            //{
            print("received");
                IPEndPoint hostIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = m_Client.Receive(ref hostIP);
                string returnData = Encoding.ASCII.GetString(data);

                Debug.Log(returnData);
            //}
        }
        catch (Exception e)
        {
            Debug.Log(e);

            OnApplicationQuit();
        }
    }

    private void OnApplicationQuit()
    {
        if (m_Thread != null)
        {
            m_Thread.Abort();
        }

        if (m_Client != null)
        {
            m_Client.Close();
        }
    }
    void udpSend()
    {
        var IP = IPAddress.Parse("192.168.43.120");

        int port = 8888;
        print("Hello");

        var udpClient1 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        var sendEndPoint = new IPEndPoint(IP, port);


        try
        {

            //Sends a message to the host to which you have connected.
            byte[] sendBytes = Encoding.ASCII.GetBytes("send");

            udpClient1.SendTo(sendBytes, sendEndPoint);
     


        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }
}