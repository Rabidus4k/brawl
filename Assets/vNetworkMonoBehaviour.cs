using FishNet.Object;
using UnityEngine;

public class vNetworkMonoBehaviour : NetworkBehaviour
{
    [SerializeField, HideInInspector]
    private bool openCloseEvents;
    [SerializeField, HideInInspector]
    private bool openCloseWindow;
    [SerializeField, HideInInspector]
    private int selectedToolbar;
}
