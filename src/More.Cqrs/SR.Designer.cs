﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace More.Domain {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("More.Domain.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to An aggregate with the identifier &apos;{0}&apos; was not found..
        /// </summary>
        internal static string AggregateNotFound {
            get {
                return ResourceManager.GetString("AggregateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to and .
        /// </summary>
        internal static string AndConjunction {
            get {
                return ResourceManager.GetString("AndConjunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The aggregate does not support creating snapshots..
        /// </summary>
        internal static string CreatingSnapshotsUnsupported {
            get {
                return ResourceManager.GetString("CreatingSnapshotsUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Persistence has already been mapped for an entity with the name &apos;{0}&apos;..
        /// </summary>
        internal static string DuplicatePersistence {
            get {
                return ResourceManager.GetString("DuplicatePersistence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression &apos;{0}&apos; does not refer to a property..
        /// </summary>
        internal static string InvalidPropertyExpression {
            get {
                return ResourceManager.GetString("InvalidPropertyExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} is not a saga..
        /// </summary>
        internal static string InvalidSaga {
            get {
                return ResourceManager.GetString("InvalidSaga", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The members used to correlate sagas to messages must be properties. Change the member {1} on type {0} to a property..
        /// </summary>
        internal static string InvalidSagaPropertyExpression {
            get {
                return ResourceManager.GetString("InvalidSagaPropertyExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An item with the {0} could not be found..
        /// </summary>
        internal static string KeyNotFound {
            get {
                return ResourceManager.GetString("KeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A handler has not been registered for the {0} command..
        /// </summary>
        internal static string MissingCommandHandler {
            get {
                return ResourceManager.GetString("MissingCommandHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Persistence has not been mapped for an entity with the name &apos;{0}&apos;..
        /// </summary>
        internal static string MissingPersistence {
            get {
                return ResourceManager.GetString("MissingPersistence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A saga must be started by at least one message. Add one or more implementations of {0} or {1} to saga type {2}..
        /// </summary>
        internal static string MissingSagaStartMessage {
            get {
                return ResourceManager.GetString("MissingSagaStartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple handlers have been registered for the {0} command, but only a single handler is allowed. The registered handlers were: {1}.
        /// </summary>
        internal static string MultipleCommandHandlers {
            get {
                return ResourceManager.GetString("MultipleCommandHandlers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} implements multiple sagas. Only a single saga implementation per type is supported..
        /// </summary>
        internal static string MultipleSagaImplementations {
            get {
                return ResourceManager.GetString("MultipleSagaImplementations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A message receiver has not been configured..
        /// </summary>
        internal static string NoConfiguredMessageReceiver {
            get {
                return ResourceManager.GetString("NoConfiguredMessageReceiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A message sender has not been configured..
        /// </summary>
        internal static string NoConfiguredMessageSender {
            get {
                return ResourceManager.GetString("NoConfiguredMessageSender", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Persistence has not been configured..
        /// </summary>
        internal static string NoConfiguredPersistence {
            get {
                return ResourceManager.GetString("NoConfiguredPersistence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sagas are not currently supported because no saga storage has been configured..
        /// </summary>
        internal static string NoConfiguredSagaStorage {
            get {
                return ResourceManager.GetString("NoConfiguredSagaStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to or .
        /// </summary>
        internal static string OrConjunction {
            get {
                return ResourceManager.GetString("OrConjunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the correlated property {0} on saga {1} has changed from &apos;{2}&apos; to &apos;{3}&apos;. Changing the value of correlated properties at runtime is currently not supported..
        /// </summary>
        internal static string SagaCorrelationPropertyModified {
            get {
                return ResourceManager.GetString("SagaCorrelationPropertyModified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The correlated property {0} on saga {1} does not have a value. A correlation property must have a non-default value assigned when a new saga instance is created..
        /// </summary>
        internal static string SagaCorrelationPropertyUnassigned {
            get {
                return ResourceManager.GetString("SagaCorrelationPropertyUnassigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The saga {0} does not support timeouts for the {1} event because the saga does not implement {2}..
        /// </summary>
        internal static string SagaDoesNotSupportTimeout {
            get {
                return ResourceManager.GetString("SagaDoesNotSupportTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A change to the ISagaData.Id property on the saga {0} has been detected. This property is for infrastructure purposes only and should not be modified..
        /// </summary>
        internal static string SagaIdModified {
            get {
                return ResourceManager.GetString("SagaIdModified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The saga {0} must be correlated to at least one property defined by the messages that trigger its activation..
        /// </summary>
        internal static string SagaNotCorrelated {
            get {
                return ResourceManager.GetString("SagaNotCorrelated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The saga property {0} of type {1} does not match the message property {2} of type {3}..
        /// </summary>
        internal static string SagaPropertyExpressionIncompatible {
            get {
                return ResourceManager.GetString("SagaPropertyExpressionIncompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A method with a single parameter of type {0} and no return value was not found..
        /// </summary>
        internal static string SingleParameterMethodNotFound {
            get {
                return ResourceManager.GetString("SingleParameterMethodNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sagas can only be correlated on a single property, but the properties {1} were configured for the saga of type {0}..
        /// </summary>
        internal static string TooManySagaCorrelationProperties {
            get {
                return ResourceManager.GetString("TooManySagaCorrelationProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The saga {0} is correlated to message {1} in the CorrelateUsing method, but the saga does not handle that message. If the saga is supposed to handle this message, then it should implement {2}..
        /// </summary>
        internal static string UnhandledSagaMessage {
            get {
                return ResourceManager.GetString("UnhandledSagaMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message type {0} can start the saga {1}, but the saga does not have a mapping between the message and saga data. Define the correlation between the message and the saga using the CorrelateUsing method..
        /// </summary>
        internal static string UnmappedSagaStartMessage {
            get {
                return ResourceManager.GetString("UnmappedSagaStartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} is not supported for correlated properties. Change the correlation property {1} on saga {2} to Guid, String, Int16, Int32, Int64, UInt16, UInt32, or UInt64..
        /// </summary>
        internal static string UnsupportedCorrelationValueType {
            get {
                return ResourceManager.GetString("UnsupportedCorrelationValueType", resourceCulture);
            }
        }
    }
}
