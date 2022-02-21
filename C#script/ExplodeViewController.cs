using System.Collections.Generic;
using UnityEngine;

namespace MRTK.Tutorials.GettingStarted
{
    public class ExplodeViewController : MonoBehaviour
    {
        public delegate void ExplodeViewControllerDelegate();

        [SerializeField] private float speed = 0.1f;
        [SerializeField] private List<GameObject> defaultPositions = default;
        [SerializeField] private List<GameObject> explodedPositions = default;

        private bool isPunEnabled;

        private readonly List<Vector3> explodedPos = new List<Vector3>();
        private readonly List<Vector3> startingPos = new List<Vector3>();

        private bool isInDefaultPosition;
        public bool isMovable = true;
        private bool Havebeeninplace = false;
        private int number = 0;
        public bool IsPunEnabled
        {
            set => isPunEnabled = value;
        }

        private void Start()
        {
            // Cache references
            foreach (var item in defaultPositions) startingPos.Add(item.transform.localPosition);
            foreach (var item in explodedPositions) explodedPos.Add(item.transform.localPosition);

        }

        private void Update()
        {
            // Reverse position based on the current position state
            if (isInDefaultPosition)
            {
                // Move objects to exploded positions
                for (var i = 0; i < defaultPositions.Count; i++)
                {
                    if (defaultPositions[i].transform.localPosition != explodedPos[i])
                    {
                        if (!Havebeeninplace)
                            defaultPositions[i].transform.localPosition = Vector3.Lerp(
                                defaultPositions[i].transform.localPosition,
                                explodedPos[i], speed);
                    }
                    else
                        number++;
                }
                if (number == defaultPositions.Count)
                    Havebeeninplace = true;
            }
            else
            { 
                // Move objects to default positions
                for (var i = 0; i < defaultPositions.Count; i++)
                {
                    if (defaultPositions[i].transform.localPosition != startingPos[i])
                    {
                        if (!Havebeeninplace)
                            defaultPositions[i].transform.localPosition = Vector3.Lerp(
                                defaultPositions[i].transform.localPosition,
                                startingPos[i], speed);
                    }
                    else
                        number++;
                }
                if (number == defaultPositions.Count)
                    Havebeeninplace = true;
            }
            number = 0;
        }

        /// <summary>
        ///     Triggers the exploded view feature.
        ///     Hooked up in Unity.
        /// </summary>
        public void ToggleExplodedView()
        {
            if (isPunEnabled)
                OnToggleExplodedView?.Invoke();
            else
                Toggle();
        }

        /// <summary>
        ///     Toggles the exploded view.
        /// </summary>
        public void Toggle()
        {
            // Toggle the current position state
            isInDefaultPosition = !isInDefaultPosition;
            Havebeeninplace = false;
        }

        /// <summary>
        ///     Raised when ToggleExplodedView is called and PUN is enabled.
        /// </summary>
        public event ExplodeViewControllerDelegate OnToggleExplodedView;
    }
}
