using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class UnitTests
{
    [Test]
    public void NewTestScriptSimplePasses()
    {

    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    // leaving in above comments while I still learn testing through Unity, will be removed in the future 
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        yield return null;
    }
    [Test]
    public void InitialTest()
    {
        bool isActive = false;
        Assert.AreEqual(false, isActive);
    }
}
