using System;

namespace Sholo.HomeAssistant.Client.Rest
{
    public abstract class BaseCreateOrUpdateStateResult<TState>
    {
        public CreateOrUpdateStateResultType StateAction { get; }
        public TState State { get; }
        public Uri EntityUri { get; }

        protected BaseCreateOrUpdateStateResult(CreateOrUpdateStateResultType stateAction, TState state, Uri entityUri)
        {
            StateAction = stateAction;
            State = state;
            EntityUri = entityUri;
        }
    }
}
