using Vuforia;
using UnityEngine;

public class TargetVirtualButtonManager : MonoBehaviour
{
    [Header("�n��ť���������s")]
    public VirtualButtonBehaviour vbbBite;
    [Header("�n����ʵe����")]
    public Animator aniTarget;

    private void Start()
    {
        // �������s ���U���U��n���檺��k
        vbbBite.RegisterOnButtonPressed(PlayBiteAnimation);
    }

    /// <summary>
    /// ����ʵe��k�A�������s���U�n���檺��k
    /// </summary>
    /// <param name="vbb"></param>
    private void PlayBiteAnimation(VirtualButtonBehaviour vbb)
    {
        print(vbbBite.name);
    }
}
