/************************************************************************************
Copyright : Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.

Your use of this SDK or tool is subject to the Oculus SDK License Agreement, available at
https://developer.oculus.com/licenses/oculussdk/

Unless required by applicable law or agreed to in writing, the Utilities SDK distributed
under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
ANY KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.
************************************************************************************/

using Oculus.Interaction.GrabAPI;
using Oculus.Interaction.Input;
using UnityEngine;
using UnityEngine.Assertions;

namespace Oculus.Interaction
{
    public class HandPinchOffset : MonoBehaviour
    {
        [SerializeField, Interface(typeof(IHand))]
        private MonoBehaviour _hand;
        public IHand Hand { get; private set; }

        [SerializeField]
        private HandGrabAPI _handGrabApi;

        [SerializeField, Optional]
        private Collider _collider = null;

        protected bool _started = false;

        protected virtual void Awake()
        {
            Hand = _hand as IHand;
        }

        protected virtual void Start()
        {
            this.BeginStart(ref _started);
            Assert.IsNotNull(Hand);
            Assert.IsNotNull(_handGrabApi);
            this.EndStart(ref _started);
        }

        protected virtual void OnEnable()
        {
            if (_started)
            {
                Hand.WhenHandUpdated += HandleHandUpdated;
            }
        }

        protected virtual void OnDisable()
        {
            if (_started)
            {
                Hand.WhenHandUpdated -= HandleHandUpdated;
            }
        }

        private void HandleHandUpdated()
        {
            Vector3 center = _handGrabApi.GetPinchCenter();
            if (_collider != null)
            {
                transform.position = _collider.ClosestPoint(center);
            }
            else
            {
                transform.position = center;
            }
        }

        #region Inject

        public void InjectAllHandPinchOffset(IHand hand,
            HandGrabAPI handGrabApi)
        {
            InjectHand(hand);
            InjectHandGrabAPI(handGrabApi);
        }

        public void InjectHand(IHand hand)
        {
            Hand = hand;
            _hand = hand as MonoBehaviour;
        }

        public void InjectHandGrabAPI(HandGrabAPI handGrabApi)
        {
            _handGrabApi = handGrabApi;
        }

        public void InjectOptionalCollider(Collider collider)
        {
            _collider = collider;
        }

        #endregion
    }
}
