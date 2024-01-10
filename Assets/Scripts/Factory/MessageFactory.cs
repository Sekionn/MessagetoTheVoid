using UnityEngine;


public class MessageFactory : Factory
{
    [SerializeField] private GameObject messagePrefab;

    public override void CreateMessageObject(string message)
    {
        var variableForPrefab = (GameObject)Resources.Load("prefab/Message", typeof(GameObject));

        GameObject instance = Instantiate(variableForPrefab, Vector3.zero, Quaternion.identity);
        VoidMessage messageInstance = instance.GetComponent<VoidMessage>();
        messageInstance.Initialize(message);
    }
}
