using System;

// Test fixture for Lattice. It does nothing: it only carries the metadata Lattice reads from a mod.
[assembly: Aether.AetherMod("lattice_test_mod", "1.2.0", Name = "Lattice Test Mod", Author = "ultimaibrahim")]

namespace Aether
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public sealed class AetherModAttribute : Attribute
    {
        public AetherModAttribute(string id, string version) { Id = id; Version = version; }
        public string Id { get; }
        public string Version { get; }
        public string? Name { get; set; }
        public string? Author { get; set; }
    }
}

namespace LatticeTestMod
{
    public static class Hello
    {
        public static string Greeting => "Hello from a Lattice test mod.";

        // Test fixture for the update flow: this version "can use the network" (never called), so Lattice must send it to review.
        public static System.Threading.Tasks.Task<string> CheckForNews() => new System.Net.Http.HttpClient().GetStringAsync("https://example.com/news.txt");
    }
}
