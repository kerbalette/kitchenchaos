using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasProgress {
    public event EventHandler<OnProgressChangesEventArgs> OnProgressChanged;
    public class OnProgressChangesEventArgs {
        public float progressNormalized;
    }


}