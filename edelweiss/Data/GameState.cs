using System.Collections.Generic;

namespace edelweiss.Data
{
    public class GameState
    {
        public List<Evidence> CollectedEvidence { get; private set; } = new();
        public bool AllEvidenceCollected => CollectedEvidence.Count >= 3;
    public string? AccusedSuspectId { get; set; }

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


        public List<Suspect> Chapter1Suspects { get; } = new()
        {
            new Suspect { Id = "briggs", Name = "Mr. Briggs", Description = "The night security guard. Was he really just doing his rounds?", IsCulprit = false },
            new Suspect { Id = "professor_hale", Name = "Professor Hale", Description = "Edel's academic advisor. Seemed unusually anxious about the disappearance.", IsCulprit = true },
            new Suspect { Id = "classmate_juno", Name = "Juno", Description = "A classmate who shared the computer lab with Edel that night.", IsCulprit = false },
            new Suspect { Id = "dorm_mate", Name = "Cass", Description = "Edel's roommate. Claims to have been asleep the whole time.", IsCulprit = false },
        };

        public void ResetChapter1()
        {
            CollectedEvidence.Clear();
            AccusedSuspectId = null;
        }
    }
}

