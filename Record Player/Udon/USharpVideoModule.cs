using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace UdonSharp.Video.Examples
{
    public class USharpVideoModule : UdonSharpBehaviour
    {
        public USharpVideoPlayer USharpVideo;
        public VideoPlayerManager Internals;
        [HideInInspector] public VRCUrl url = VRCUrl.Empty;
        [HideInInspector] public bool canControlVideoPlayer;
        [HideInInspector] public bool isPlaying;
        [HideInInspector] public float length;
        [HideInInspector] public float currentTime;
        [HideInInspector] public VRCUrl currentURL = VRCUrl.Empty;

        public void _CheckURL()
        {
            currentURL = (VRCUrl)USharpVideo.GetProgramVariable("_syncedURL");
        }

        public void _UpdateVideoPlayerStatus()
        {
            isPlaying = Internals.IsPlaying();
            length = Internals.GetDuration();
            currentTime = System.Convert.ToSingle(USharpVideo.GetProgramVariable("_lastCurrentTime"));
        }

        public void _UpdateCanControlVideoPlayer()
        {
            canControlVideoPlayer = USharpVideo.CanControlVideoPlayer();
        }

        void Start()
        {
            USharpVideo.RegisterCallbackReceiver(this);
        }

        public void _PlayVideoViaModule()
        {
            USharpVideo.PlayVideo(url);
        }
    }
}