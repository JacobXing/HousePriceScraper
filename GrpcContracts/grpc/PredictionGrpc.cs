﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: prediction.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace House.Prediction
{
    public static partial class PredictionService
    {
        static readonly string __ServiceName = "House.Prediction.PredictionService";

        static readonly grpc::Marshaller<global::House.Prediction.PredictionRequest> __Marshaller_PredictionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::House.Prediction.PredictionRequest.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::House.Prediction.PredictionResponse> __Marshaller_PredictionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::House.Prediction.PredictionResponse.Parser.ParseFrom);

        static readonly grpc::Method<global::House.Prediction.PredictionRequest, global::House.Prediction.PredictionResponse> __Method_FindNearestHouseIndices = new grpc::Method<global::House.Prediction.PredictionRequest, global::House.Prediction.PredictionResponse>(
            grpc::MethodType.Unary,
            __ServiceName,
            "FindNearestHouseIndices",
            __Marshaller_PredictionRequest,
            __Marshaller_PredictionResponse);

        /// <summary>Service descriptor</summary>
        public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return global::House.Prediction.PredictionReflection.Descriptor.Services[0]; }
        }

        /// <summary>Base class for server-side implementations of PredictionService</summary>
        public abstract partial class PredictionServiceBase
        {
            /// <summary>
            /// Find the indices of nearest houses
            /// </summary>
            /// <param name="request">The request received from the client.</param>
            /// <param name="context">The context of the server-side call handler being invoked.</param>
            /// <returns>The response to send back to the client (wrapped by a task).</returns>
            public virtual global::System.Threading.Tasks.Task<global::House.Prediction.PredictionResponse> FindNearestHouseIndices(global::House.Prediction.PredictionRequest request, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

        }

        /// <summary>Client for PredictionService</summary>
        public partial class PredictionServiceClient : grpc::ClientBase<PredictionServiceClient>
        {
            /// <summary>Creates a new client for PredictionService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public PredictionServiceClient(grpc::Channel channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for PredictionService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public PredictionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected PredictionServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected PredictionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Find the indices of nearest houses
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::House.Prediction.PredictionResponse FindNearestHouseIndices(global::House.Prediction.PredictionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
            {
                return FindNearestHouseIndices(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Find the indices of nearest houses
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::House.Prediction.PredictionResponse FindNearestHouseIndices(global::House.Prediction.PredictionRequest request, grpc::CallOptions options)
            {
                return CallInvoker.BlockingUnaryCall(__Method_FindNearestHouseIndices, null, options, request);
            }
            /// <summary>
            /// Find the indices of nearest houses
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::House.Prediction.PredictionResponse> FindNearestHouseIndicesAsync(global::House.Prediction.PredictionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
            {
                return FindNearestHouseIndicesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Find the indices of nearest houses
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::House.Prediction.PredictionResponse> FindNearestHouseIndicesAsync(global::House.Prediction.PredictionRequest request, grpc::CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_FindNearestHouseIndices, null, options, request);
            }
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override PredictionServiceClient NewInstance(ClientBaseConfiguration configuration)
            {
                return new PredictionServiceClient(configuration);
            }
        }

        /// <summary>Creates service definition that can be registered with a server</summary>
        /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
        public static grpc::ServerServiceDefinition BindService(PredictionServiceBase serviceImpl)
        {
            return grpc::ServerServiceDefinition.CreateBuilder()
                .AddMethod(__Method_FindNearestHouseIndices, serviceImpl.FindNearestHouseIndices).Build();
        }

    }
}
#endregion
