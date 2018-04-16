﻿using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts {

	public class GridBackgroundController : MonoBehaviour {

		[UsedImplicitly]
		private void OnEnable () {
			transform.localPosition = Z.VGridBackground;
		}

	}

}