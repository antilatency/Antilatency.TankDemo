﻿// Copyright 2020, ALT LLC. All Rights Reserved.
// This file is part of Antilatency SDK.
// It is subject to the license terms in the LICENSE file found in the top-level directory
// of this distribution and at http://www.antilatency.com/eula
// You may not use this file except in compliance with the License.
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Antilatency.Alt.Tracking;
using Antilatency.Integration;

public class RobotTracking : AltTrackingTag {
    protected override void Update() {
        base.Update();
        if (!GetTrackingState(out var trackingState)) {
            stability = new Stability();
            return;
        }
        stability = trackingState.stability;
        var robotTransform = transform;
        robotTransform.localPosition = trackingState.pose.position;
        robotTransform.localRotation = trackingState.pose.rotation;
    }
    public Stability stability;
}