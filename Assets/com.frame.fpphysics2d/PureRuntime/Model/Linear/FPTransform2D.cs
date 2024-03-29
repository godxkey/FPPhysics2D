using FixMath.NET;

namespace JackFrame.FPPhysics2D {

    public class FPTransform2D {

        // - World
        FPVector2 pos;
        public FPVector2 Pos => pos;

        FPRotation2D rot;
        public FPRotation2D Rot => rot;

        FP64 radAngle;
        public FP64 RadAngle => radAngle;

        // - Local
        FPVector2 localPos;
        public FPVector2 LocalPos => localPos;

        FPRotation2D localRot;
        public FPRotation2D LocalRot => localRot;

        FP64 localRadAngle;
        public FP64 LocalRadAngle => localRadAngle;

        public FPTransform2D(in FPVector2 pos, in FP64 radAngle) {
            this.pos = pos;
            this.radAngle = radAngle;
            this.rot = new FPRotation2D(radAngle);
        }

        public void SetPos(in FPVector2 pos) {
            this.pos = pos;
        }

        public void SetRot(in FPRotation2D rot) {
            this.rot = rot;
            this.radAngle = rot.RadAngle;
        }

        public void SetRadianAngle(in FP64 angle) {
            this.radAngle = angle;
            this.rot = new FPRotation2D(angle);
        }

        public void SetLocalPos(in FPVector2 localPos) {
            this.localPos = localPos;
        }

        public void SetLocalRot(in FPRotation2D localRot) {
            this.localRot = localRot;
            this.localRadAngle = localRot.RadAngle;
        }

        public void SetLocalRadianAngle(in FP64 localAngle) {
            this.localRadAngle = localAngle;
            this.localRot = new FPRotation2D(localAngle);
        }

    }

}