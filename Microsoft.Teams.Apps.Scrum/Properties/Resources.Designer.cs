﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Teams.Apps.Scrum.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Teams.Apps.Scrum.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   * に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AstreixSymbol {
            get {
                return ResourceManager.GetString("AstreixSymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   解決が必要な相談事項があれば共有してください に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string BlockersText {
            get {
                return ResourceManager.GetString("BlockersText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   現在スクラムが実行されていません。アクティブなスクラムを終了するにはこのコマンドを使用してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string CompleteScrumErrorText {
            get {
                return ResourceManager.GetString("CompleteScrumErrorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムを終了する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string CompleteScrumText {
            get {
                return ResourceManager.GetString("CompleteScrumText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムの終了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string CompleteScrumTitle {
            get {
                return ResourceManager.GetString("CompleteScrumTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   同時に実行できるスクラムは１つです。終了後フォーム上の[スクラムの終了]をクリックしてください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string CompleteScrumTourText {
            get {
                return ResourceManager.GetString("CompleteScrumTourText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong. Please try again later..
        /// </summary>
        internal static string ErrorMessage {
            get {
                return ResourceManager.GetString("ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   問題が発生しました。後ほど再試行してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string GenericErrorMessage {
            get {
                return ResourceManager.GetString("GenericErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムはメンバーが20人以下のグループチャットでしか使用できません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MemberCountErrorMessage {
            get {
                return ResourceManager.GetString("MemberCountErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   アクティブなスクラムがありません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NoActiveScrumTitle {
            get {
                return ResourceManager.GetString("NoActiveScrumTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {0} あなたは実行中のスクラムのメンバーではありません。スクラムのアクティブメンバーのみが実行中のスクラムを終了できます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NoPartOfCompleteScrumText {
            get {
                return ResourceManager.GetString("NoPartOfCompleteScrumText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {0} あなたは現在実行中のスクラムのメンバーではありません。スクラムが終了されたのち新しいスクラムを開始できます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NoPartOfScrumStartText {
            get {
                return ResourceManager.GetString("NoPartOfScrumStartText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   あなたは実行中のスクラムのメンバーではありません。次回以降のスクラムで更新内容を入力できます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NoPartOfScrumUpdateText {
            get {
                return ResourceManager.GetString("NoPartOfScrumUpdateText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {0} あなたは実行中のスクラムのメンバーではありません。現在のアクティブなスクラムが終了したのち新しいスクラムを開始できます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NotPartofScrumText {
            get {
                return ResourceManager.GetString("NotPartofScrumText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   情報を入力してください（最大1000字） に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string PlaceholderText {
            get {
                return ResourceManager.GetString("PlaceholderText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   同時に実行できるスクラムは１つです。新しいスクラムを開始するには現在のスクラムを終了してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string RunningScrumMessage {
            get {
                return ResourceManager.GetString("RunningScrumMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   現在スクラムはグループチャットでのみ使用可能です。スクラムを更新するにはグループチャットにスクラムをインストールしてください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScopeErrorMessage {
            get {
                return ResourceManager.GetString("ScopeErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {1}、スクラムが{0}によって終了されました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScrumCompletedByText {
            get {
                return ResourceManager.GetString("ScrumCompletedByText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   おつかれさまでした！このスクラムは終了しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScrumCompleteText {
            get {
                return ResourceManager.GetString("ScrumCompleteText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   以下のコマンドのみがサポートされます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScrumHelpMessage {
            get {
                return ResourceManager.GetString("ScrumHelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {1}、スクラムが{0}によって開始されました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScrumRequestedByText {
            get {
                return ResourceManager.GetString("ScrumRequestedByText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムの更新 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScrumTaskModuleTitle {
            get {
                return ResourceManager.GetString("ScrumTaskModuleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {1}、スクラムが{0}によって更新されました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScrumUpdatedByText {
            get {
                return ResourceManager.GetString("ScrumUpdatedByText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   詳細ステータス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ShowScrumDetailsTitle {
            get {
                return ResourceManager.GetString("ShowScrumDetailsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムの開始 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string StartCarouselCardTitle {
            get {
                return ResourceManager.GetString("StartCarouselCardTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムが開始されるとメンバーが現在のステータスを入力するフォームが作成されます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string StartCommandTourTextPart1 {
            get {
                return ResourceManager.GetString("StartCommandTourTextPart1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムを開始しますか？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string StartCommandTourTextPart2 {
            get {
                return ResourceManager.GetString("StartCommandTourTextPart2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムの開始 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string StartText {
            get {
                return ResourceManager.GetString("StartText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   完了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SubmitTitle {
            get {
                return ResourceManager.GetString("SubmitTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ツアーの開始 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TakeATourButtonText {
            get {
                return ResourceManager.GetString("TakeATourButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スクラムの機能をツアーで確認します。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TakeTourWelcomeMessage {
            get {
                return ResourceManager.GetString("TakeTourWelcomeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   次回までの達成目標を共有してください に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TodayText {
            get {
                return ResourceManager.GetString("TodayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このフィールドは空欄にできません に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TodayValidationText {
            get {
                return ResourceManager.GetString("TodayValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {0} に最終更新 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string UpdateScrumTimeStampText {
            get {
                return ResourceManager.GetString("UpdateScrumTimeStampText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ステータスの更新 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string UpdateScrumTitle {
            get {
                return ResourceManager.GetString("UpdateScrumTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   想定されたテナントからのユーザーではありません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WarningTextForTenantFailure {
            get {
                return ResourceManager.GetString("WarningTextForTenantFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   チームメンバーのステータス更新を確認しましょう。グループチャットのメンバー全員が参加できます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WelcomeCardContentPart1 {
            get {
                return ResourceManager.GetString("WelcomeCardContentPart1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   もっと知るには？ツアーを開始しましょう！ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WelcomeCardContentPart2 {
            get {
                return ResourceManager.GetString("WelcomeCardContentPart2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ようこそ！ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WelcomeText {
            get {
                return ResourceManager.GetString("WelcomeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   現在までの進行状況を共有してください に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string YesterdayText {
            get {
                return ResourceManager.GetString("YesterdayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このフィールドは空欄にできません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string YesterdayValidationText {
            get {
                return ResourceManager.GetString("YesterdayValidationText", resourceCulture);
            }
        }
    }
}
