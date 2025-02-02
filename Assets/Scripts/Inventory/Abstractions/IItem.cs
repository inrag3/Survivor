﻿using System;
using UnityEditor;
using UnityEngine;

public interface IItem
{
    IItemInfo Info { get; }
    IItemState State { get; }
    IItem Clone(int amount);
    bool Equal(IItem item);
    void Use();
}