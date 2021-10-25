using Vuforia;
using UnityEngine;

public class TargetVirtualButtonManager : MonoBehaviour
{
    [Header("要監聽的虛擬按鈕")]
    public VirtualButtonBehaviour vbbBite;
    [Header("要控制的動畫元件")]
    public Animator aniTarget;

    private void Start()
    {
        // 虛擬按鈕 註冊按下後要執行的方法
        vbbBite.RegisterOnButtonPressed(PlayBiteAnimation);
    }

    /// <summary>
    /// 播放動畫方法，虛擬按鈕按下要執行的方法
    /// </summary>
    /// <param name="vbb"></param>
    private void PlayBiteAnimation(VirtualButtonBehaviour vbb)
    {
        print(vbbBite.name);
    }
}
