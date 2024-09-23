using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAds : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    private string _androidGameID = "5679300";
    private string _iosGameID = "5679301";

    private bool _isTestMode = true;
    private string _gameID;

    private string _androidAdUnitId = "Interstitial_Android";
    private string _iOsAdUnitId = "Interstitial_iOS";
    string _adUnitId;

    private static int _countLoses;

    private void Awake()
    {
        InitializeAds();
        _countLoses++;
        if (_countLoses % 3 == 0) {
            Advertisement.Load(_adUnitId, this); } }
        

        private void InitializeAds()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                _gameID = _iosGameID;
                _adUnitId = _iOsAdUnitId;
            }
            else
            {
                _gameID = _androidGameID;
                _adUnitId = _androidAdUnitId;  
            }

            Advertisement.Initialize(_gameID, _isTestMode, this);
        }

        public void OnInitializationComplete()
        {
            Advertisement.Load(_adUnitId, this);
        }

        public void OnInitializationFailed(UnityAdsInitializationError error, string message)
        {
            Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
        }

        // Implement Load Listener and Show Listener interface methods: 
        public void OnUnityAdsAdLoaded(string adUnitId)
        {
            Advertisement.Show(_adUnitId, this);
        }

        public void OnUnityAdsFailedToLoad(string _adUnitId, UnityAdsLoadError error, string message)
        {
            Debug.Log($"Error loading Ad Unit: {_adUnitId} - {error.ToString()} - {message}");
            // Optionally execute code if the Ad Unit fails to load, such as attempting to try again.
        }

        public void OnUnityAdsShowFailure(string _adUnitId, UnityAdsShowError error, string message)
        {
            Debug.Log($"Error showing Ad Unit {_adUnitId}: {error.ToString()} - {message}");
            // Optionally execute code if the Ad Unit fails to show, such as loading another ad.
        }

        public void OnUnityAdsShowStart(string _adUnitId) { }
        public void OnUnityAdsShowClick(string _adUnitId) { }
        public void OnUnityAdsShowComplete(string _adUnitId, UnityAdsShowCompletionState showCompletionState) { }
    }
