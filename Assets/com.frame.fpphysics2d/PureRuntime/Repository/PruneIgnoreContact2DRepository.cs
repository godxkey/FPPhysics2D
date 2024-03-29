using System.Linq;
using System.Collections.Generic;

namespace JackFrame.FPPhysics2D {

    public class PruneIgnoreContact2DRepository {

        SortedDictionary<ulong, PruneIgnoreContact2DModel> all;

        public PruneIgnoreContact2DRepository() {
            this.all = new SortedDictionary<ulong, PruneIgnoreContact2DModel>();
        }

        public void Add(PruneIgnoreContact2DModel model) {
            all.Add(model.key, model);
        }

        public bool Contains(ulong key) {
            return all.ContainsKey(key);
        }

        public KeyValuePair<ulong, PruneIgnoreContact2DModel>[] GetAll() {
            return all.ToArray();
        }

        public void Remove(ulong key) {
            this.all.Remove(key);
        }

        public void Clear() {
            all.Clear();
        }

    }

}