using UnityEngine;
using UnityEngine.UI;

public class SchrankenManager : MonoBehaviour
{
    [SerializeField] Button schranken1;
    [SerializeField] Button schranken2;
    [SerializeField] GameObject Player;
    public void Schranken1()
    {
        schranken1.image.enabled = false;

    }
    public void Schranken2()
    {
        schranken2.image.enabled = false;
    }

    public void SchrankenOffen()
    {
        if (schranken1.image.enabled == false && schranken2.image.enabled == false)
        {
            Player.transform.position = new Vector3(6.24f, 0f, 0f);
        }
    }
}
