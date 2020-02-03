using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1_v2
{
    public abstract class Enemy : MonoBehaviour
    {
        public IEnemyBehavior enemyBehavior;
        public virtual void DoMove() { enemyBehavior.Move(); }
        public abstract void Die();
        // Start is called before the first frame update
    }
}
