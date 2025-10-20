using UnityEngine;
/// <summary>
/// en la interface se puede definir metodos abstractos
/// </summary>
public interface IMovementStrategy
{
    public void move(Transform transform , float speed);


}
