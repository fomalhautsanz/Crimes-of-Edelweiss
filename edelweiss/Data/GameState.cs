using System.Collections.Generic;

namespace edelweiss.Data
{
    public class GameState
    {
        public List<Evidence> CollectedEvidence { get; private set; } = new();

        public void AddEvidence(Evidence evidence)
        {
            // Avoid duplicates if the player clicks the same button twice
            if (!CollectedEvidence.Exists(e => e.Id == evidence.Id))
            {
                CollectedEvidence.Add(evidence);
            }
        }

        public bool HasEvidence(string id)
        {
            return CollectedEvidence.Exists(e => e.Id == id);
        }
    }
}