using JaLoader;
using System.Collections.Generic;
using UnityEngine;

namespace Santa_hat
{

    public class Santa_hat : Mod
    {
        /// <summary>
        /// The mod's ID. Try making it as unique as possible, to avoid conflicting IDs.
        /// </summary>
        public override string ModID => "Santahat";

        /// <summary>
        /// The mod's name. This is shown in the mods list. Does not need to be unique.
        /// </summary>
        public override string ModName => "Santa hat";

        /// <summary>
        /// The mod's author (you). Also shown in the mods list.
        /// </summary>
        public override string ModAuthor => "Liebeg";

        /// <summary>
        /// The mod's description. This is also shown in the mods list, upon clicking on "More Info".
        /// </summary>
        public override string ModDescription => "A santa hat for the Laika.";

        /// <summary>
        /// The mod's version. Also shown in the mods list. 
        /// If your mod is open-source on GitHub, make sure that you're using the same format as your release tags (for example, 1.0.0)
        /// For more information, check out the wiki page on versioning. (https://github.com/theLeaxx/JaLoader/wiki/Versioning-your-mod)
        /// </summary>
        public override string ModVersion => "1.0.0";

        /// <summary>
        /// If your mod is open-source on GitHub, you can link it here to allow for automatic update-checking in-game.
        /// It compares the current ModVersion with the tag of the latest release (ex. 1.0.0 compared with 1.0.1)
        /// For more information, check out the wiki page on versioning. (https://github.com/theLeaxx/JaLoader/wiki/Versioning-your-mod)
        /// </summary>
        public override string GitHubLink => "https://github.com/Liebeg/Santahat-jalopy";

        /// <summary>
        /// When to initialize the mod.
        /// InGame: When the game is loaded, stops functioning in the main menu.
        /// InMenu: When the main menu is loaded, continues to function in-game too.
        /// </summary>
        public override WhenToInit WhenToInit => WhenToInit.InGame;

        /// <summary>
        /// If you mod depends on a certain version of JaLoader, or another mod, you can specify it here. 
        /// The format is (ModID, ModAuthor, ModVersion), and for JaLoader it's ("JaLoader", "Leaxx", {version}).
        /// Versions are usually formatted in the (x.y.z) format (for example, 1.2.0), although certain mods may follow other formats.
        /// Enable Debug Mode in JaLoader settings to view ModIDs instead of ModNames in the mod list.
        /// If you don't have any dependencies, you can just return an empty list.
        /// For more information, check out the wiki page on dependencies. (https://github.com/theLeaxx/JaLoader/wiki/Using-dependencies)
        /// </summary>
        public override List<(string, string, string)> Dependencies => new List<(string, string, string)>()
        {
        };

        /// <summary>
        /// If your mod uses custom assets, you need to set this to true.
        /// In other words, if your mod uses the "LoadAsset>T>" function, you need to set this to true.
        /// For more information, check out the wiki page on custom assets. (https://github.com/theLeaxx/JaLoader/wiki/Using-custom-assets)
        /// </summary>
        public override bool UseAssets => true;
        private GameObject santahat;
        /// <summary>
        /// Declare all of your events here.
        /// Events are used to call functions when certain things happen in-game.
        /// They are held by the script "EventsManager". You can use "EventsManager.Instance.{event} += FunctionName()" to subscribe to them.
        /// For more information, check out the wiki page on events. (https://github.com/theLeaxx/JaLoader/wiki/Using-events)
        /// </summary>
        public override void EventsDeclaration()
        {
            base.EventsDeclaration();
        }

        /// <summary>
        /// Declare all of your settings here.
        /// Make sure to call "InstantiateSettings()" in here before declaring your settings.
        /// For more information, check out the wiki page on settings. (https://github.com/theLeaxx/JaLoader/wiki/Adding-settings-for-mods)
        /// </summary>
        public override void SettingsDeclaration()
        {
            base.SettingsDeclaration();
        }

        /// <summary>
        /// Register all of your custom objects here.
        /// Custom objects are objects that are not part of the game's default objects, but act like them.
        /// Basically, if you want to add a new object to the game that can be picked up/placed/etc, you need to register it here.
        /// For more information, check out the wiki page on custom objects. (https://github.com/theLeaxx/JaLoader/wiki/Using-Custom-Objects)
        /// </summary>
        public override void CustomObjectsRegistration()
        {
            base.CustomObjectsRegistration();


            santahat = LoadAsset<GameObject>("santahat", "hat", "", ".prefab");
            santahat = Instantiate(santahat, ModHelper.Instance.laika.transform.Find("TweenHolder/Frame"));
            santahat.transform.localPosition = new Vector3(0.66f, 0.57f, 0);
          santahat.transform.localScale = new Vector3(220, 220, 110);
           santahat.transform.localEulerAngles = new Vector3(274.2f, 144, 62);


            ModHelper.Instance.CreateIconForExtra(santahat, new Vector3(), new Vector3(0.5f, 0.5f, 0.5f), new Vector3(180, 60, 200), "Santahat");

            CustomObjectsManager.Instance.RegisterObject(ModHelper.Instance.CreateExtraObject(santahat, BoxSizes.Medium, "Santahat", "A santa hat, to make your car stand out even more.", 80, 10, "Santahat", AttachExtraTo.Body), "Santahat");
        }

        /// <summary>
        /// This is the default Unity OnEnable() function, called as soon as the mod is enabled, before Awake() & Start().
        /// </summary>
        public override void OnEnable()
        {
            base.OnEnable();
        }

        /// <summary>
        /// This is the default Unity Awake() function, called as soon as the mod is enabled, before Start().
        /// </summary>
        public override void Awake()
        {
            base.Awake();
        }

        /// <summary>
        /// This is the default Unity Start() function, called when the mod is enabled.
        /// </summary>
        public override void Start()
        {
            base.Start();
        }

        /// <summary>
        /// This is the default Unity Update() function, called every frame after the mod is enabled.
        /// </summary>
        public override void Update()
        {
            base.Update();
        }

        /// <summary>
        /// This is the default Unity OnDisable() function, called when the mod is disabled.
        /// </summary>
        public override void OnDisable()
        {
            base.OnDisable();
        }
    }
}
