using UnityEngine;

namespace FactoryMethod
{
    public abstract class Enemy : MonoBehaviour
    {
        [Header("---- REFERENCES ----")]
        [SerializeField] private EnemyId _id;

        public string ID => _id.Value;
    }
}