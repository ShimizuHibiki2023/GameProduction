using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//作成者：桑原

public interface IPlayerState
{
    void Enter();
    void Update();
    void Exit();
}
