using UnityEngine;

namespace FactoryMethod
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Factory Method/Enemy")]
    public class EnemyId : ScriptableObject
    {
        [Header("---- PARAMETERS ----")]
        [SerializeField] private string _value;

        public string Value => _value;
    }
}