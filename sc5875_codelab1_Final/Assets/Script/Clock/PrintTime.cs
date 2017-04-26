using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Security;
using System.Net;
using SimpleJSON;

public class PrintTime : MonoBehaviour {
	public string state;
	public string city;
	public Text whatTime;
	
	JSONNode CityData;
	string time;

	void Awake(){
		ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;

		string content = DataFromCity (city, state);
		CityData = JSON.Parse (content);

		time = CityData ["query"] ["results"] ["channel"] ["lastBuildDate"];

		whatTime.text = time;
	}

	void Update(){
		string content = DataFromCity (city, state);
		CityData = JSON.Parse (content);

		time = CityData ["query"] ["results"] ["channel"] ["lastBuildDate"];

		whatTime.text = time;
	}
	//Solve the internet, ignore all of them
	public bool MyRemoteCertificateValidationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
		bool isOk = true;
		// If there are errors in the certificate chain, look at each error to determine the cause.
		if (sslPolicyErrors != SslPolicyErrors.None) {
			for (int i=0; i<chain.ChainStatus.Length; i++) {
				if (chain.ChainStatus [i].Status != X509ChainStatusFlags.RevocationStatusUnknown) {
					chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
					chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
					chain.ChainPolicy.UrlRetrievalTimeout = new System.TimeSpan (0, 1, 0);
					chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
					bool chainIsValid = chain.Build ((X509Certificate2)certificate);
					if (!chainIsValid) {
						isOk = false;
					}
				}
			}
		}
		return isOk;
	}

	string DataFromCity(string _city, string _state)
	{
		string address;
		//string jsonString;
		WebClient client = new WebClient();

		address = "https://query.yahooapis.com/v1/public/yql?q=select%20" +
			"*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22" +
			_city +
			"%2C%20" +
			_state +
			"%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

		//jsonString = client.DownloadString (address);

		//return jsonString;
		return client.DownloadString(address);
	}	
}
