using UnityEngine;
using UnityEngine.Advertisements;

public class ads : MonoBehaviour
{
  public void ShowAd()
  {
    if (Advertisement.IsReady())
    {
      Advertisement.Show();
    }
  }
}
